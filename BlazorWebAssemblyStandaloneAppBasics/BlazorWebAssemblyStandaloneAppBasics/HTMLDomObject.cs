public class HTMLDomObject
{
    public string id = "";
    public string bgcolor = "red";

    public HTMLDomObject(string id, string bgcolor = "")
    {
        this.id = id;
        this.bgcolor = bgcolor;
    }
}

public static class HTMLDom
{
    public static List<HTMLDomObject> domObjects = new List<HTMLDomObject>();

    public static HTMLDomObject FindByID(string id)
    {
        HTMLDomObject found = domObjects.FirstOrDefault(x => x.id == id);
        if (found == null) Console.WriteLine("Error, FindByID dom object not found with id: " + id);
        return found;
    }
}