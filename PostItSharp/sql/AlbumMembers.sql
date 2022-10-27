-- Active: 1666715469942@@SG-wood-cinema-3385-6834-mysql-master.servers.mongodirector.com@3306@garbagecollector

CREATE TABLE
    IF NOT EXISTS album_members(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        albumId INT NOT NULL,
        accountId VARCHAR(255) NOT NULL,
        FOREIGN KEY (albumId) REFERENCES albums(id),
        FOREIGN KEY (accountId) REFERENCES accounts(id)
    ) default charset utf8 COMMENT '';