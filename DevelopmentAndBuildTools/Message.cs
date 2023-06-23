namespace DevelopmentAndBuildTools
{
    public class Message
    {
        public static int GetString(string s) 
        {
            if (s != string.Empty)
            {
                int maxChar = 1,
                currentChar = 1;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] != s[i + 1])
                    {
                        currentChar++;
                    }
                    else
                    {
                        currentChar = 1;
                    }
                    if (currentChar > maxChar)
                    {
                        maxChar = currentChar;
                    }
                }
                return maxChar;
            }
            return 0;
        }
    }
}
