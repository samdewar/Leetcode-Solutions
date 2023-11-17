// https://leetcode.com/problems/longest-substring-without-repeating-characters/ Completed
public class Solution {
    string subStr="";
    string temp="";
    int repLoc;
    public int LengthOfLongestSubstring(string s) {
        // s="sam is cool";
        
        for(int i=0;i<s.Length && !timeWaste(s,i);i++){
            if(checker(s[i])) 
            {
                
                temp=temp+s[i];

                if(subStr.Length<temp.Length)
                {
                    subStr=temp;
                }


            }
            else
            {
                // Console.WriteLine($"{temp}  *{s[i]}* {repLoc}");
                temp=temp.Substring(repLoc+1)+s[i];
                // Console.WriteLine(temp);
                
            }
        }

        return subStr.Length;
    }

    public bool timeWaste(String s, int i){
        i++;
        if(subStr.Length>(temp.Length+s.Length-i)) return true;
        return false;
    }

    public bool checker(char c){

        for(int i=0;i<temp.Length;i++){
            if(temp[i]==c){
            repLoc=i;
            return false;
            }
        }


        return true;
    }
}