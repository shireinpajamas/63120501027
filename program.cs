using System;
					
public class Program
{
	public static void Main()
	{
		secret_intelligence_service_access_program();
	}
	public static void secret_intelligence_service_access_program(){
		bool Ispass;
		string[] password={"","","","","","",""};
		string association;
		
		Console.WriteLine("input 6 number password ");
		for (int i = 0; i < 6;i++) {
			password[i] =  Console.ReadLine();
		}
		
		
		Console.WriteLine("input association's name ");
	     association =  Console.ReadLine();
		 Ispass = false;
		if(association == "CIA"||association == "FBI"||association == "NSA"){
			if(association == "CIA"&& int.Parse(password[5])%3== 0&& password[4]!="1"&& password[4]!="3"&& password[4]!="5"&&int.Parse(password[3])>6&&password[3]!="8"){
			Ispass = true;
			}
			else if(association =="FBI"&&int.Parse( password[1])>=4 &&int.Parse(password[1])<7 && int.Parse(password[3])%2==0&& password[3]!="6"&&int.Parse(password[2])%2!=0){
			Ispass = true;	
			}
			else if(association=="NSA"&& 30%int.Parse(password[5])==0&&int.Parse(password[2]) % 3 ==0&&int.Parse(password[2]) % 2 !=0&&Array.Find(password,element => element.StartsWith("7"))=="7"){
			Ispass = true;
			}
		}
		else{
			Ispass = false;	
		}
		Console.WriteLine("Output:" + Ispass);
	}
}