Im gonna call this project as CommunisInventory lol. name can be changed later on

# TODO FRONTEND
- Make frontend using radzen C#.
- File upload limit will be 10mb or 25mb
- When user upload there will be a popup and a form that need to be filled
  - Username
  - Category
  - UploadFile
- Make TAB for Home, Upload, UploadList
  - Home : Short Summary of what the website is
  - Upload : Upload file
  - UploadList : List of all the uploaded file that will be sort by category/date/alpabetical
 
# TODO BACKEND
- Need to decided which framework API that need to be use
- api/GetFiles : getting list of files
  - GET Parameter : Category,Date, Username = null
  - Return : List of files 

- api/Upload : Upload files
  - POST Parameter : category,date,username
  - Return : string / responsecode

### More to come probably

# TODO DATABASE 
- Need to decided which database that we gonna use
- Probably only need 1 table, that contains
  - index
  - username
  - filename
  - category
  - date  
