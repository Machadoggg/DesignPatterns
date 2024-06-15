

using DesignPatterns.BehaviorPattern.ChainOfResponsibility;

User salesPerson = new SalesPerson();
User salesManager = new SalesManager();
User director = new Director();

salesPerson.SetSuccessor(salesManager);
salesManager.SetSuccessor(director);

// Create and process sales requests
SalesRequest r1 = new SalesRequest("Small Sale", 1000.00, "Sale of office supplies");
salesPerson.HandleRequest(r1);

SalesRequest r2 = new SalesRequest("Medium Sale", 15000.00, "Sale of computers");
salesPerson.HandleRequest(r2);

SalesRequest r3 = new SalesRequest("Large Sale", 100000.00, "Sale of office furniture");
salesPerson.HandleRequest(r3);