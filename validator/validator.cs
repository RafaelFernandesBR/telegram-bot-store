using Newtonsoft.Json.Linq;

namespace telegram.validator
{
public class validator
{

public bool validarUser(string chatId)
{
        StreamReader r = new StreamReader("userAdmin.json");
        string validaUser = r.ReadToEnd();
        var json = JArray.Parse(validaUser);
        bool admin = false;
        foreach (var user in json)
        {
            if (Convert.ToString(user["userId"]) == Convert.ToString(chatId))
            {
                admin = true;
            }
        }

        return admin;
}

}
}
