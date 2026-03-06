CREATE TABLE Tasks (
    TaskID INT IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(100),
    Description VARCHAR(255),
    Status VARCHAR(20)
);