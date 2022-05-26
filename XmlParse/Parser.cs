namespace XmlParse;

public static class Parser
{
    public static string Parse(string key, string source)
    {
        int startPos, startPos2, startPosEnd;
        int endPos;
        string keyMod = $"<{key} ";
        string endMod = $"</{key}";
        startPos = source.IndexOf(keyMod);
        startPos2 = startPos + keyMod.Length;
        startPosEnd = source.IndexOf(">", startPos2) + 1;
        endPos = source.IndexOf(endMod,startPos);
        string result =  source.Substring(startPosEnd, endPos - startPosEnd);
        return result;

    }
}