#Function for XOR of two strings 10101 and 00101

def XOR(s,t):
    if len(s) != len(t):
        print("Error: Strings are not equal in length")
        return
    else:
        result = ""
        for i in range(len(s)):
            if s[i] == t[i]:
                result += "0"
            else:
                result += "1"
        return str(result)

s = input()
print(s)
t = input()
print(t)
print(XOR(s, t))