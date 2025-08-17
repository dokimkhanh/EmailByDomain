# Mail-Filter-Pro (EmailByDomain)

A simple C# console tool to filter or categorize email addresses by domain.

# Screenshot
![image](https://user-images.githubusercontent.com/40461705/178149650-4b4f120e-6f33-4e59-bf0f-42d6affb4ed3.png)

## Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download) (or adjust accordingly)
- Works on Windows/Linux/macOS

## Usage

1. Clone the repository:
```
git clone https://github.com/dokimkhanh/EmailByDomain.git
cd EmailByDomain
```
2. Build:
```
dotnet build
```
3. Run with an input file:
```
dotnet run -- input_emails.txt
```
- input_emails.txt: one email per line.
- Output files are generated per domain, e.g., gmail.com_emails.txt.

# Example

Input (example_input.txt):
```
alice@gmail.com
bob@yahoo.com
carol@gmail.com
```
Output:

gmail.com_emails.txt contains:
```
alice@gmail.com
carol@gmail.com
```



## Development

Open the .sln in Visual Studio or run directly via CLI.

To extend: add filters (e.g., support wildcard domains), or provide domain counts.
## Contribute
Feel free to open issues or submit pull requests.
## License

[MIT](https://choosealicense.com/licenses/mit/)

This project is licensed under the MIT License. See LICENSE for details.
