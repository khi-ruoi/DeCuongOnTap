USE DeCuongOnTap;
-- Thêm Học kỳ
INSERT INTO dbo.Semester
(
    SemName,
    Status
)
VALUES
(   N'Giữa Kỳ 1', -- SemName - nvarchar(50)
    1             -- Status - bit
    );

INSERT INTO dbo.Semester
(
    SemName,
    Status
)
VALUES
(   N'Cuối Kỳ 1', -- SemName - nvarchar(50)
    1             -- Status - bit
    );

INSERT INTO dbo.Semester
(
    SemName,
    Status
)
VALUES
(   N'Giữa Kỳ 2', -- SemName - nvarchar(50)
    1             -- Status - bit
    );

INSERT INTO dbo.Semester
(
    SemName,
    Status
)
VALUES
(   N'Cuối Kỳ 2', -- SemName - nvarchar(50)
    1             -- Status - bit
    );

-- Thêm Khối
INSERT INTO dbo.Grade
(
    GradeName,
    Status
)
VALUES
(   N'Khối 1', -- GradeName - nvarchar(50)
    1          -- Status - bit
    );

INSERT INTO dbo.Grade
(
    GradeName,
    Status
)
VALUES
(   N'Khối 2', -- GradeName - nvarchar(50)
    1          -- Status - bit
    );


INSERT INTO dbo.Grade
(
    GradeName,
    Status
)
VALUES
(   N'Khối 3', -- GradeName - nvarchar(50)
    1          -- Status - bit
    );


INSERT INTO dbo.Grade
(
    GradeName,
    Status
)
VALUES
(   N'Khối 4', -- GradeName - nvarchar(50)
    1          -- Status - bit
    );


INSERT INTO dbo.Grade
(
    GradeName,
    Status
)
VALUES
(   N'Khối 5', -- GradeName - nvarchar(50)
    1          -- Status - bit
    );

-- Thêm môn học
INSERT INTO dbo.Subject
(
    SubjectName,
    Status
)
VALUES
(   N'Toán', -- SubjectName - nvarchar(50)
    1        -- Status - bit
    );

INSERT INTO dbo.Subject
(
    SubjectName,
    Status
)
VALUES
(   N'Tiếng Việt', -- SubjectName - nvarchar(50)
    1              -- Status - bit
    );

INSERT INTO dbo.Subject
(
    SubjectName,
    Status
)
VALUES
(   N'Tiếng Anh', -- SubjectName - nvarchar(50)
    1             -- Status - bit
    );

INSERT INTO dbo.Subject
(
    SubjectName,
    Status
)
VALUES
(   N'Khoa học', -- SubjectName - nvarchar(50)
    1            -- Status - bit
    );

INSERT INTO dbo.Subject
(
    SubjectName,
    Status
)
VALUES
(   N'Lịch sử', -- SubjectName - nvarchar(50)
    1           -- Status - bit
    );
-- Thêm Giáo viên
INSERT INTO dbo.Teacher
(
    UserName,
    Password,
    FullName,
    DOB,
    Status
)
VALUES
(   N'a',         -- UserName - nvarchar(50)
    N'mrdH+093L08=',         -- Password - nvarchar(100)
    N'Vinh',      -- FullName - nvarchar(50)
    '01/01/2001', -- DOB - varchar(10)
    1             -- Status - bit
    );

INSERT INTO dbo.Teacher
(
    UserName,
    Password,
    FullName,
    DOB,
    Status
)
VALUES
(   N'b',         -- UserName - nvarchar(50)
    N'mrdH+093L08=',         -- Password - nvarchar(100)
    N'Huyền',     -- FullName - nvarchar(50)
    '02/02/2002', -- DOB - varchar(10)
    0             -- Status - bit
    );

	

SELECT *
FROM dbo.Administrator;
SELECT *
FROM Authority;
SELECT *
FROM dbo.Subject;
SELECT *
FROM dbo.Teacher;
SELECT *
FROM dbo.EssayTest;
SELECT * FROM dbo.MultiChoice;

