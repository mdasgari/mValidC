using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.RegularExpressions;
using Moshk;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
dynamic a= JObject.Parse(@"{""b"":[ 1 , 2 ]}");
dynamic b=null;
string s="123456";
Console.WriteLine((a["b"][0]).Type);
Console.WriteLine(a["b"].Type);

Console.WriteLine(int.Parse(s.Substring(0,1)));
dynamic rules="A;B";
var bb=((string)rules).Trim().Split(";").Where(el => !(el is null || el.Trim()=="")).Select(el => el);
Console.WriteLine(bb.GetType());
Console.WriteLine(bb.First());
Console.WriteLine(bb.ElementAt(0));
Console.WriteLine(bb.ElementAt(1));
Console.WriteLine(bb.Count());
foreach(var h in bb){
    Console.WriteLine(h);
}

var c=JObject.Parse(@"{""A"":1,""B"":""C""}");
var param="c";
var p=c.Properties().FirstOrDefault(st=>(st.Name.ToLower()==param.ToLower()));
if(p is null)Console.WriteLine("null");
else Console.WriteLine(p.Name);
string[] Z={"A","B","C","D","D"};
Console.WriteLine(Array.IndexOf(Z,"B"));

Console.WriteLine(Moshk.M.JSONSchemaValidator.PatternValidate("Date","2001/01/01").ToString());
//is Object