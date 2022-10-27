-- Active: 1666715469942@@SG-wood-cinema-3385-6834-mysql-master.servers.mongodirector.com@3306@garbagecollector

CREATE TABLE
    IF NOT EXISTS pictures(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        imgUrl VARCHAR(255) NOT NULL,
        creatorId VARCHAR(255) NOT NULL,
        albumId INT NOT NULL,
        FOREIGN KEY (creatorId) REFERENCES accounts(id),
        FOREIGN KEY (albumId) REFERENCES albums(id)
    ) default charset utf8 COMMENT '';