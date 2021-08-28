var filtered = from value in values
where value > 4
select value;

var sorted = from value in values 
orderby value
select value;

var sorted = from value in filtered 
orderby value descending
select value;