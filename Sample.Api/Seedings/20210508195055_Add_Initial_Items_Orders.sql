DECLARE @mouseId INT
INSERT INTO Items([Name], [Description]) Values ('Logitech MX Master 2s', 'Logitech wireless mouse')
SET @mouseId = @@IDENTITY

DECLARE @keyboardId INT
INSERT INTO Items([Name], [Description]) Values ('Microsoft Sculpt Ergonomic keyboard', 'Microsoft ergonomic keyboard')
SET @keyboardId = @@IDENTITY

DECLARE @speakersId INT
INSERT INTO Items([Name], [Description]) Values ('CREATIVE Pebbles', 'Desktop speakers')
SET @speakersId = @@IDENTITY

DECLARE @orderId INT
INSERT INTO Orders(CreatedOn) values (GETUTCDATE())
SET @orderId = @@IDENTITY

INSERT INTO OrderItems(OrderId, ItemId, Quantity) Values (@orderId, @mouseId, 3)
INSERT INTO OrderItems(OrderId, ItemId, Quantity) Values (@orderId, @keyboardId, 1)
INSERT INTO OrderItems(OrderId, ItemId, Quantity) Values (@orderId, @speakersId, 2)