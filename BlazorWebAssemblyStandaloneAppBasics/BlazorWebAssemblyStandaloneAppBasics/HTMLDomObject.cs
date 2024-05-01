public class HTMLDomObject
{
    public string id;
    public string bgcolor = "";
    public string text;

    public HTMLDomObject(string id, string bgcolor = "", string text = "")
    {
        this.id = id;
        this.bgcolor = bgcolor;
        this.text = text;
    }
}

public static class HTMLDom
{
    public static List<HTMLDomObject> domObjects = new List<HTMLDomObject>();

    public static HTMLDomObject FindByID(string id)
    {
        HTMLDomObject? found = domObjects.FirstOrDefault(x => x.id == id);

        if (found == null)
        {
            Console.WriteLine("Error, FindByID dom object not found with id: " + id);
        }

        return found;
    }
}