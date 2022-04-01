using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace telegram.Data
{
	public class dataInfo
{
        private MySqlConnection conm {get; set;}

        public int id{ get; set; }
        public string Nome { get; set; }
        public string vercao {get; set; }
public string descricao{get; set; }
public string url{get; set; }

        public dataInfo()
        {
//get a file json
StreamReader r = new StreamReader("telegram.json");
string readFile= r.ReadToEnd();
conectSql conectData= JsonConvert.DeserializeObject<conectSql>(readFile);

			this.conm = new MySqlConnection("Server="+conectData.server+";Database="+conectData.Database+";Uid="+conectData.user+";Pwd="+conectData.senha+";SSL Mode=None");
        }

        private List<dataInfo> GetAllFClass(string query)
        {
			            List<dataInfo> data = new List<dataInfo>();

            this.conm.Open();
            MySqlCommand cmd = new MySqlCommand(query, this.conm);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data.Add(new dataInfo
{
//get a data em mysql
id = Convert.ToInt32(reader["id"]),	
Nome =Convert.ToString(reader["nome"]),
vercao=Convert.ToString(reader["vercao"]),
descricao =Convert.ToString(reader["descricao"]),
url=Convert.ToString(reader["url"])
});
            }
            reader.Close();
            this.conm.Close();
return data;
}

private void DeletInsert(string query)
{
            this.conm.Open();
            MySqlCommand cmd = new MySqlCommand(query, this.conm);
            cmd.ExecuteNonQuery();
            this.conm.Close();
}

//return all
public List<dataInfo> GetAll(string query)
{
var data=GetAllFClass(query);
return data;
}

//delet fron id
        public void DeleteAndInsert(string query)
        {
DeletInsert(query);
}

}
}
