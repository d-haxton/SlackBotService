using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot.Models;
using MargieBot.Responders;
using Newtonsoft.Json;
using RepositoryEngine.data;
using RepositoryEngine.repository;
using ScriptingEngine.CSharpScripting;
using SlackApi.interfaces;

namespace SlackApi.responders
{
    public interface ICommandResponder : IResponder
    {
        
    }
    public class CommandResponder : ICommandResponder
    {
        private readonly ICommands _commands;
        private readonly IScriptRepository _scriptRepository;
        private readonly IBadWordRepository _badWordRepository;
        private readonly ITriviaController _triviaController;

        public CommandResponder(ICommands commands, IScriptRepository scriptRepository, IBadWordRepository badWordRepository, ITriviaController triviaController)
        {
            _commands = commands;
            _scriptRepository = scriptRepository;
            _badWordRepository = badWordRepository;
            _triviaController = triviaController;
        }

        public bool CanRespond(ResponseContext context)
        {
            var command = context.Message.Text.Split(' ').FirstOrDefault();
            if (string.IsNullOrEmpty(command))
                return false;
            return _commands.EnumerableCommands.Any(x => x == command);
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var command = context.Message.Text.Split(' ').FirstOrDefault();
            var splitMessage = context.Message.Text.Split(' ');
            switch (command)
            {
                case "!trivia":
                    var triviaOutput = "";
                    try
                    {
                        var e = splitMessage[1] == "start";
                        _triviaController.PushUpdate(e);
                    }
                    catch (Exception ex)
                    {
                        triviaOutput = ex.Message;
                    }
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = triviaOutput
                    };
                case "!quiz":
                    // do quiz logic
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = "Do quiz shutff."
                    };
                case "!badword":
                    var badwordOutput = "Bad word has been added";
                    try
                    {


                        var badword = new BadWords {Word = splitMessage[1]};
                        if (splitMessage[2].ToLower() == "warn")
                        {
                            badword.Action = EBadWord.Warn;
                        }
                        else if (splitMessage[2].ToLower() == "flag")
                        {
                            badword.Action = EBadWord.Warn;
                        }
                        else if (splitMessage[2].ToLower() == "remove")
                        {
                            badword.Action = EBadWord.Remove;
                        }
                        else
                        {
                            badword.Action = EBadWord.Warn;
                        }
                        _badWordRepository.Insert(badword);
                    }
                    catch (Exception ex)
                    {
                        badwordOutput = ex.Message;
                    }
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = badwordOutput
                    };
                case "!compile":
                    string output;
                    try
                    {
                        var id = context.Message.Text.Split(' ')[1];
                        var cs = new CSharp();
                        var script = _scriptRepository.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(id));
                        output = JsonConvert.SerializeObject(cs.Compile(script?.ScriptText));
                    }
                    catch(Exception ex)
                    {
                        output = ex.Message;
                    }
                    // do compile logic
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = output
                    };
                case "!help":
                    // do help logic
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = "Help."
                    };
                case "!attendance":
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = "Attendance."
                    };
                default:
                    return new BotMessage()
                    {
                        ChatHub = context.Message.ChatHub,
                        Text = "Command not recognized. I have no idea how I got here, but I shouldn't have been able to. Beep boop. Blame Litman."
                    };
            }
        }
    }
}
