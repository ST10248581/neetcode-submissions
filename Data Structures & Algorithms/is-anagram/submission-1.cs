public class Solution {
    public bool IsAnagram(string s, string t) {

        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();

        //If Strings have different lengths they cannot be anagrams
        if (s.Length != t.Length) return false;

        //Add up counts for 'S'
        Dictionary<char, int> sCharCounts = new Dictionary<char, int>();
        for(int c = 0; c < sChars.Length; c++){   

            if(sCharCounts.ContainsKey(sChars[c])){
             
                // increase existing count
                sCharCounts[sChars[c]] = sCharCounts[sChars[c]] + 1;
            }
            else
            {
                sCharCounts.Add(sChars[c], 1);
            }
        }

        //Compare each char of t to s
         for(int c = 0; c < tChars.Length; c++){      

            if(sCharCounts.ContainsKey(tChars[c]))
             {
                // If the count is already 0, t contains more of this character than s, so return false.
                if (sCharCounts[tChars[c]] == 0) return false;

                // Decrement the s count as we are one step closer to a match
                sCharCounts[tChars[c]] = sCharCounts[tChars[c]] - 1;
            }
            else{
                //Letter in t not in s
                return false;
            }
        }

        //Same length, same numbers of characters;
        return true;

    }
}
