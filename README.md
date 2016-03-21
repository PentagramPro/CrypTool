# CrypTool
Tool intended for developers who deal with cryptography. Originaly I created this tool for myself but I decided to make it availible on GitHub.
When you develop security libraries or work with cryptographic devices you often need a tool to check cryptograms and keys, to create some test data, etc. And you want this tool to be predictable.

## Features

CrypTool allows cryptographic operations to be performed on custom data. One can use online tools for that purpose, but they have one or more of the following problems:
  * They accept input either in text or in hex but not both. Sometimes they suppose that you work with ASCII when you need Unicode.
  * They accidentally perform padding
  * You can't trust them sensitive data, can you?
  
CrypTool has several input modes:
  * HEX
  * ASCII 
  * Unicode
  
CrypTool never does any manipulations with input which can confuse user. It does not pad on its own, it does not break input into blocks. it just notifies about argument error. However, CrypTool has separate padding generator if you want manual padding to be done.
Currently CrypTool supports:
  * 3DES
  * RSA
  
Hash algorithms:
  * MD5
  * SHA-1
  
  
  
