USE StudentDemo
GO

Create database StudentDemo
GO

CREATE TABLE Student (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Age INT NOT NULL
);

GO
-- Insert some records
INSERT INTO Student (Name, City, Age) VALUES ('John Doe', 'New York', 20);
INSERT INTO Student (Name, City, Age) VALUES ('Jane Smith', 'Los Angeles', 22);
INSERT INTO Student (Name, City, Age) VALUES ('Sam Brown', 'Chicago', 19);

GO
