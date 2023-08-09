CREATE TABLE cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(54) NOT NULL,
    id_endereco INT NOT NULL,
    cpf VARCHAR(11) NOT NULL,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE endereco (
    id INT PRIMARY KEY IDENTITY(1,1),
    endereco VARCHAR(100) NOT NULL,
    estado VARCHAR(30) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    cep VARCHAR(8) NOT NULL,
    referencia TEXT,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE animal (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(54) NOT NULL,
    observacoes TEXT,
    id_especie INT NOT NULL,
    id_cliente INT NOT NULL,
    cor VARCHAR(50),
    numero_identificacao VARCHAR(50),
    data_nascimento DATE,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE especie (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(50) NOT NULL,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE consulta (
    id INT PRIMARY KEY IDENTITY(1,1),
    data DATE NOT NULL,
    observacoes TEXT,
    id_animal INT NOT NULL,
    id_cliente INT NOT NULL,
    id_funcionario INT NOT NULL,
    id_venda INT,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE exame (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(50) NOT NULL,
    resultado TEXT,
    id_consulta INT NOT NULL,
    cancelado BIT NOT NULL DEFAULT 0,
    data DATE
);

CREATE TABLE medicacao (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(100) NOT NULL,
    dosagem VARCHAR(100) NOT NULL,
    id_consulta INT NOT NULL,
    lote VARCHAR(54) NOT NULL,
    validade DATE NOT NULL,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE funcionario (
    id INT PRIMARY KEY IDENTITY(1,1),
    id_cargo INT NOT NULL,
    nome VARCHAR(54) NOT NULL,
    salario DECIMAL(10,2) NOT NULL,
    email VARCHAR(64) NOT NULL,
    login VARCHAR(54) NOT NULL,
    senha VARCHAR(54) NOT NULL,
    data_criacao DATE NOT NULL,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE cargo (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(50) NOT NULL,
    descricao TEXT,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE produto (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    preco_custo DECIMAL(10,2) NOT NULL,
    quantidade INT NOT NULL,
    codigo VARCHAR(255),
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE venda (
    id INT PRIMARY KEY IDENTITY(1,1),
    data_venda DATE NOT NULL,
    valor_total DECIMAL(10,2) NOT NULL,
    id_funcionario INT NOT NULL,
    desconto DECIMAL(10,2) NOT NULL,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE item_venda (
    id INT PRIMARY KEY IDENTITY(1,1),
    quantidade INT NOT NULL,
    valor_unitario DECIMAL(10,2) NOT NULL,
    id_produto INT NOT NULL,
    id_venda INT NOT NULL
);

CREATE TABLE formas_pagamento (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(54) NOT NULL,
    descricao TEXT,
    status BIT NOT NULL DEFAULT 1
);

CREATE TABLE pagamentos (
    id INT PRIMARY KEY IDENTITY(1,1),
    valor DECIMAL(10, 2) NOT NULL,
    data_pagamento DATE NOT NULL,
    id_forma_pagamento INT NOT NULL,
    parcelado BIT NOT NULL,
    numero_parcelas INT,
    data_vencimento DATE,
    id_venda INT NOT NULL,
    status BIT NOT NULL
);

CREATE TABLE pagamentos_parcelados (
    id INT PRIMARY KEY IDENTITY(1,1),
    numero_parcelas INT,
    valor_parcela DECIMAL(10,2),
    data_vencimento DATE,
    id_pagamento INT NOT NULL,
    status BIT NOT NULL
);

ALTER TABLE cliente ADD FOREIGN KEY (id_endereco) REFERENCES endereco (id);
ALTER TABLE animal ADD FOREIGN KEY (id_cliente) REFERENCES cliente (id);
ALTER TABLE consulta ADD FOREIGN KEY (id_animal) REFERENCES animal (id);
ALTER TABLE consulta ADD FOREIGN KEY (id_funcionario) REFERENCES funcionario (id);
ALTER TABLE exame ADD FOREIGN KEY (id_consulta) REFERENCES consulta (id);
ALTER TABLE medicacao ADD FOREIGN KEY (id_consulta) REFERENCES consulta (id);
ALTER TABLE funcionario ADD FOREIGN KEY (id_cargo) REFERENCES cargo (id);
ALTER TABLE item_venda ADD FOREIGN KEY (id_produto) REFERENCES produto (id);
ALTER TABLE item_venda ADD FOREIGN KEY (id_venda) REFERENCES venda (id);
ALTER TABLE pagamentos ADD FOREIGN KEY (id_forma_pagamento) REFERENCES formas_pagamento (id);
ALTER TABLE pagamentos_parcelados ADD FOREIGN KEY (id_pagamento) REFERENCES pagamentos (id);
ALTER TABLE animal ADD FOREIGN KEY (id_especie) REFERENCES especie (id);
