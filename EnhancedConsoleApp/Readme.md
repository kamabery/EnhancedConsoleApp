The below needs to go in a .template.config directory in a project root in a file named template.json
```json
{
  "$schema": "http://json.schemastore.org/template",
  "author": "Your Name",
  "classifications": [ "Web" ],
  "name": "Templat Name",
  "identity": "Templates namespace",
  "description": "Brief description of the template",
  "shortName": "Microservice",
  "tags": {
    "language": "C#"
  },
  "sourceName": "String you want to replace with directory name",
  "preferNameDirectory": "true",
  "sources": [{ "modifiers": [{ "exclude": [".vs/**", ".git/**"] }] }],
  "symbols": {
    "ServiceTopic": {
      "type": "parameter",
      "datatype": "string",
      "FileRename": "Part of file name to rename",
      "description": "what this parameter should change",
      "defaultValue": "Defuale falue",
      "replaces": "What string to replace"
    },
    "myRandomNumber": {
      "type": "generated",
      "generator": "random",
      "parameters": {
        "low": 20000,
        "high": 65000
      },
      "replaces": "48322"
    }
  }
}
```