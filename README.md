# Csharp-RemoveReplace
A challenge to extract, replace, and remove data from an input string

Given string:
----------------------------
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

Rule
----------------------------
1. Set the quantity variable to the value obtained by extracting the text between the <span> and </span> tags.
2. Set the output variable to the value of input, then remove the <div> and </div> tags.

Expected output:
----------------------------
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
