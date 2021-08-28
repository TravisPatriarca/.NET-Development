// load
XmlReader reader = XmlReader.create("sample.xml");
XElement element = XElement.Load(reader);

//save
XElement element = new XElement("foo");
element.Save(@"c:\temp\foo.xml");