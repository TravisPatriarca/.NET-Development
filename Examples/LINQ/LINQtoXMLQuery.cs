IEnumerable<string> partNos = from item in PurchaseOrder.Descendants("Item")
select (string) item.Attribute("PartNumber");