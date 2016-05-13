using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MargieBot.Models;
using MargieBot.Responders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace SlackApi.responders
{
    public interface IScriptingResponder : IResponder
    {
        
    }
    public class ScriptingResponder : IScriptingResponder
    {
        public IScriptRepository ScriptRepository { get; set; }

        public ScriptingResponder(IScriptRepository scriptRepository)
        {
            ScriptRepository = scriptRepository;
        }

        public bool CanRespond(ResponseContext context)
        {
            var message = context.Message;
            if (message.RawData.Contains("url_private_download"))
            {
                return true;
            }
            return false;
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var message = context.Message;
            dynamic parsedJson = JObject.Parse(message.RawData);
            var url = parsedJson.file.url_private.Value;
            var text = Encoding.UTF8.GetString(GetFileViaHttp(url));

            var script = new Script()
            {
                CreatedBy = message.User.ID,
                CreatedOn = DateTime.Now.ToString(CultureInfo.CurrentCulture),
                Executions = 0,
                Id = Guid.NewGuid(),
                ScriptText = text,
                Type = EScriptType.CSharp
            };
            ScriptRepository.Insert(script);
            return new BotMessage()
            {
                ChatHub = context.Message.ChatHub,
                Text = $"Script {script.Id} has been created."
            };
        }

        public byte[] GetFileViaHttp(string url)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Authorization"] = "Bearer " + "xoxb-23425258787-dvCEaiSiqKkjuzhOrMBSGZRi";
                return client.DownloadData(url);
            }
        }
    }
}
