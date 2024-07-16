using System.Diagnostics;

using var doc = new XMLDocument(false, Whitespace.COLLAPSE_WHITESPACE);

var element = doc.NewElement("iq");
element.SetAttribute("from", "k01.warface.servers");
element.SetAttribute("to", "dedicated@warface/PVE-64058");
element.SetAttribute("type", "result");
element.SetAttribute("id", "uid" + 32.ToString("x8"));

var query = element.InsertNewChildElement("query");
query.SetAttribute("xmlns", "urn:cryonline:k01");

var setserver = query.InsertNewChildElement("setserver");
setserver.SetAttribute("master_node", "127.0.0.1");

using var print = new XMLPrinter();
element.Accept(print);

var xml = print.CStr();
Debugger.Break();