import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        //input 2 string 
        Scanner sc = new Scanner(System.in);
        String s1 = sc.next();
        String s2 = sc.next();
        XOR_class(s1, s2);

    }

    public static void XOR_class(String s,String t)
    {
        if (s.length() != t.length()) {
    System.out.println("Error: Strings are not equal in length");
    }
else {
    String result = "";
    for (int i = 0; i < s.length(); i++) {
        if (s.charAt(i) == t.charAt(i)) {
            result += "0";
        }
        else {
            result += "1";
        }
    }
    System.out.println(result);
}
        
    }
}