USE master;
GO

DROP DATABASE DeCuongOnTap;
GO

CREATE DATABASE DeCuongOnTap;
GO
USE DeCuongOnTap;
-- Tạo bảng Quản trị viên
CREATE TABLE dbo.Administrator
(
    Id INT PRIMARY KEY IDENTITY,
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL
);
-- Tạo bảng Giáo Viên
CREATE TABLE dbo.Teacher
(
    Id INT PRIMARY KEY IDENTITY,
    UserName NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(50) NOT NULL,
    DOB VARCHAR(10)
        DEFAULT '00-00-00000' NOT NULL,
    Status BIT
        DEFAULT 0
);
-- Tạo Bảng Học Kỳ
CREATE TABLE dbo.Semester
(
    Id INT PRIMARY KEY IDENTITY,
    SemName NVARCHAR(50) NOT NULL UNIQUE,
    Status BIT
        DEFAULT 0
);
-- Tạo Bảng Khối lớp
CREATE TABLE dbo.Grade
(
    Id INT PRIMARY KEY IDENTITY,
    GradeName NVARCHAR(50) NOT NULL UNIQUE,
    Status BIT
        DEFAULT 0,
);
-- Tạo bảng Môn học
CREATE TABLE dbo.Subject
(
    Id INT PRIMARY KEY IDENTITY,
    SubjectName NVARCHAR(50) NOT NULL UNIQUE,
    Status BIT
        DEFAULT 1,
);
-- Tạo bảng phân quyền
CREATE TABLE Authority
(
    Id INT PRIMARY KEY IDENTITY,
    IdTeacher INT
        FOREIGN KEY REFERENCES dbo.Teacher (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdSubject INT
        FOREIGN KEY REFERENCES dbo.Subject (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdSem INT
        FOREIGN KEY REFERENCES dbo.Semester (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    IdGrade INT
        FOREIGN KEY REFERENCES dbo.Grade (Id) ON DELETE CASCADE ON UPDATE CASCADE,
    Status BIT
        DEFAULT 0
);
-- Tạo bảng Câu hỏi Trắc nghiệm
CREATE TABLE MultiChoice
(
    Id INT PRIMARY KEY IDENTITY,
    Level NVARCHAR(20),
    Question NVARCHAR(1000) NOT NULL,
    AnswerA NVARCHAR(1000),
    AnswerB NVARCHAR(1000),
    AnswerC NVARCHAR(1000),
    AnswerD NVARCHAR(1000),
    Answer NVARCHAR(1000),
    Status BIT NOT NULL
        DEFAULT 0,
    UpdateTime VARCHAR(50),
    IdAuth INT
        FOREIGN KEY REFERENCES dbo.Authority (Id) ON UPDATE CASCADE ON DELETE CASCADE
);
-- Tạo bảng câu hỏi tự luận
CREATE TABLE EssayTest
(
    Id INT PRIMARY KEY IDENTITY,
    Level NVARCHAR(20),
    Question NVARCHAR(1000) NOT NULL,
    Answer NVARCHAR(1000) NOT NULL,
    Status BIT NOT NULL
        DEFAULT 0,
    UpdateTime VARCHAR(50),
    IdAuth INT
        FOREIGN KEY REFERENCES dbo.Authority (Id) ON UPDATE CASCADE ON DELETE CASCADE
);

--Nhập thông tin
INSERT INTO dbo.Administrator
(
    UserName,
    Password
)
VALUES
(   N'admin', -- UserName - nvarchar(50)
    N'mrdH+093L08='  -- Password - nvarchar(100)
    );

