using System.Diagnostics;
using telegram.Data;
using Newtonsoft.Json;

namespace Telegram.jsonData
{
    public class jsonData
    {

        public string allApps()
        {
            dataInfo tt = new dataInfo();
            var final = tt.GetAll("SELECT * FROM aplicativosLojas");
//serealisar a lista em json
            var json = JsonConvert.SerializeObject(final);

            return json;
        }

        public string enviaDados(string nome, string vercao, string descricao, string url)
        {
            dataInfo tt = new dataInfo();
                //inserte data
            tt.Insert("INSERT INTO aplicativosLojas(nome, vercao, descricao, url) VALUES('" + nome + "','" + vercao + "','" + descricao + "','" + url + "')");
            return "Incluido com sucesso!";
        }

        public string deleteId(int id)
        {
            dataInfo tt = new dataInfo();
            //delete data
            tt.Delete("DELETE FROM aplicativosLojas WHERE id = " + id + ";");
            return "Deletado com sucesso.";
        }
    }
}
