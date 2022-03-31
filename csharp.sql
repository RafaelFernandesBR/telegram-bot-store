CREATE USER 'user'@'localhost' IDENTIFIED BY 'senha';
GRANT ALL PRIVILEGES ON * . * TO 'user'@'localhost';
FLUSH PRIVILEGES;

CREATE database apps;
use apps;
CREATE TABLE aplicativosLojas (
id INT auto_increment PRIMARY KEY,
nome text,
vercao VARCHAR(20),
descricao text,
url VARCHAR(500) );

use apps;
INSERT INTO aplicativosLojas (nome, vercao, descricao, url )
VALUES (
    'Android para cegos',
    'V22/04/30',
    'Aplicativo do android para cegos',
    'androidparacegos.com.br');

use apps;
SELECT * FROM aplicativosLojas;

use apps;
ALTER TABLE aplicativosLojas ADD vercao VARCHAR(20)  AFTER nome;

use apps;
DELETE FROM aplicativosLojas WHERE id = 1;