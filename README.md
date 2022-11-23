# League Auto Login  

This was created for people with many accounts. This will allow you to hotswap between your accounts and keep the data encrpyted in a local json file.
I created this software to get a better understanding of how reading and writing data to json files works.  

This application has [AutoIt](https://www.autoitscript.com/site/) dependancies  

## Encryption
You can easily change the Encrpytion Key, it should look like this in Main.cs:  
```csharp
public const string ENCRYPTION_KEY = "R5LeZYXebMn8F/N&";
```
The data is created at runtime locally to the application, if you change the key for multiple accounts, you will need to make sure you save those keys so you have continued access to your passwords.

## Todo
> Create a settings form so you can generate Encryption Keys and set them automatically ✅   
> Automate the closing of the Client (League client isn't a normal case because Riot is shitty and can't program) ✅  
