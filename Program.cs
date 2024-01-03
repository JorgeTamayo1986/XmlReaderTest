// See https://aka.ms/new-console-template for more information
using System;
using System.Xml;
using System.Xml.Serialization;
using XmlReaderTest;


var xmlContent = File.ReadAllText("EresElMejor.xml");

// XML content (replace with your XML content or file path)
//string xmlContent = "<Person><FirstName>John</FirstName><LastName>Doe</LastName><Age>30</Age></Person>";

// Deserialize XML into object
Envelope xml;
using (StringReader stringReader = new StringReader(xmlContent))
{
    XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
    xml = (Envelope)serializer.Deserialize(stringReader);
}

// Access the deserialized object
Console.WriteLine($"Owner: {xml.Body.XXTransactionResponse.RSP.AirShoppingRS.ShoppingResponseID.Owner}");
Console.WriteLine($"ResponseID: {xml.Body.XXTransactionResponse.RSP.AirShoppingRS.ShoppingResponseID.ResponseID}");
Console.WriteLine($"Source: {xml.Body.XXTransactionResponse.RSP.AirShoppingRS.ShoppingResponseID.Source}");

Console.ReadLine();
