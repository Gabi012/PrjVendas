-- ========================================
-- Script para popular banco VendasDB
-- ========================================

-- 1. Cargos
INSERT INTO Cargos (Nome) VALUES ('Gerente');
INSERT INTO Cargos (Nome) VALUES ('Vendedor');
INSERT INTO Cargos (Nome) VALUES ('Caixa');

-- 2. Categorias
INSERT INTO Categorias (Nome) VALUES ('Eletrônicos');
INSERT INTO Categorias (Nome) VALUES ('Alimentos');
INSERT INTO Categorias (Nome) VALUES ('Roupas');

-- 3. Funcionários
INSERT INTO Funcionarios (Nome, Cpf, CargoId, Salario) VALUES ('Carlos Silva', '11111111111', 1, 8000.00);
INSERT INTO Funcionarios (Nome, Cpf, CargoId, Salario) VALUES ('Ana Souza', '22222222222', 2, 4000.00);
INSERT INTO Funcionarios (Nome, Cpf, CargoId, Salario) VALUES ('João Pereira', '33333333333', 3, 2500.00);

-- 4. Produtos
INSERT INTO Produtos (Nome, CategoriaId, Preco) VALUES ('Smartphone', 1, 2500.00);
INSERT INTO Produtos (Nome, CategoriaId, Preco) VALUES ('Notebook', 1, 4500.00);
INSERT INTO Produtos (Nome, CategoriaId, Preco) VALUES ('Arroz 5kg', 2, 25.00);
INSERT INTO Produtos (Nome, CategoriaId, Preco) VALUES ('Camisa Polo', 3, 80.00);

-- 5. Pedidos
INSERT INTO Pedidos (Data, FuncionarioId) VALUES (GETDATE(), 2);
INSERT INTO Pedidos (Data, FuncionarioId) VALUES (GETDATE(), 2);

-- 6. ItensPedido
INSERT INTO ItensPedido (PedidoId, ProdutoId, Quantidade, ValorUnitario) VALUES (1, 1, 2, 2500.00);
INSERT INTO ItensPedido (PedidoId, ProdutoId, Quantidade, ValorUnitario) VALUES (1, 3, 5, 25.00);
INSERT INTO ItensPedido (PedidoId, ProdutoId, Quantidade, ValorUnitario) VALUES (2, 2, 1, 4500.00);
INSERT INTO ItensPedido (PedidoId, ProdutoId, Quantidade, ValorUnitario) VALUES (2, 4, 3, 80.00);

-- ========================================
-- Fim do script
-- ========================================
