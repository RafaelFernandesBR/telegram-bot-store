using Newtonsoft.Json.Linq;
using Telegram.jsonData;

namespace telegram.TratarChat
{
    public class trataChat : jsonData
    {

        public string pesquiza(string texto)
        {
            var recupera = allApps();
            var json = JArray.Parse(recupera);
            //cortar a string

            string textoTratado = null;
            //percorrer o json e adicionar no textotratado
            foreach (var item in json)
            {
                if (item["Nome"].ToString().Contains(texto, StringComparison.OrdinalIgnoreCase)
                || item["descricao"].ToString().Contains(texto, StringComparison.OrdinalIgnoreCase))
                {
                    textoTratado = $"{textoTratado}\nNome: {item["Nome"]}\nVerção: {item["vercao"]}\nDescrição: {item["descricao"]}\nURL: {item["url"]}";
                }
            }
            if (textoTratado == null)
            {
                textoTratado = "Nada encontrado";
            }

            return textoTratado;
        }

        public string todos()
        {
            var recupera = allApps();
            var json = JArray.Parse(recupera);

            string textoTratado = null;
            //percorrer a arraye adicionar no textotratado
            foreach (var item in json)
            {
                textoTratado = $"{textoTratado}\nNome: {item["Nome"]}\nVerção: {item["vercao"]}\nDescrição: {item["descricao"]}\nURL: {item["url"]}";
            }
            if (textoTratado == null)
            {
                textoTratado = "Nada encontrado";
            }

            return textoTratado;
        }

        public string incluir(string nome, string vercao, string descricao, string url)
        {
            string reculpera = enviaDados(nome, vercao, descricao, url);
            return reculpera;
        }

        public string apagar(int id)
        {
            string reculpera = deleteId(id);
            return reculpera;
        }

    }
}
