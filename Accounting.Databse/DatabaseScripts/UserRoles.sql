CREATE TABLE UserRoles (
                           UserId INT FOREIGN KEY REFERENCES Users(UserId),
                           RoleId INT FOREIGN KEY REFERENCES Roles(RoleId),
                           PRIMARY KEY(UserId, RoleId)
);