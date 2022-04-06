import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] arr = new int[n];

        for (int arr_i = 0; arr_i < n; arr_i++) {
            arr[arr_i] = in.nextInt();

            //return the XOR of all the elements of the array
        }
        //stdoout the XOR of all the elements of the array
        System.out.println(xor(arr));
        
        
    }

    private static char[] xor(int[] arr) {
        char[] result = new char[arr.length];
        for (int i = 0; i < arr.length; i++) {
            result[i] = (char) (arr[i] ^ arr[i + 1]);
        }
        return result;
    }
}