const express = require("express");
const app = express();
const port = 8000;
const faker = require('faker');

const users = [];
const companies = [];

app.use( express.json() );
app.use( express.urlencoded({ extended: true }) );


class User {
    constructor() {
        this._id = Math.floor(Math.random()*10 + 1);
        this.firstName = faker.name.firstName();
        this.lastname = faker.name.lastName();
        this.phoneNumber = faker.phone.phoneNumber();
        this.email = faker.internet.email();
        this.password = faker.internet.password();
    }
}

class Company {
    constructor() {
        this._id = Math.floor(Math.random()*10 + 1);
        this.name = faker.company.companyName();
        this.address = {
            street: faker.address.streetAddress(),
            city: faker.address.city(),
            state: faker.address.state(),
            zipCode: faker.address.zipCode(),
            country: faker.address.country
        };
    }
}

app.post("/api/users/new", (req, res) => {
    // req.body will contain the form data from Postman or from React
    console.log(req.body);
    // we can push it into the users array for now...
    // later on this will be inserted into a database
    users.push(req.body);
    // we alwats need to respond with something
    res.json( { status: "ok" } );
})

app.post("/api/companies/new", (req, res) => {
    // req.body will contain the form data from Postman or from React
    console.log(req.body);
    // we can push it into the users array for now...
    // later on this will be inserted into a database
    companies.push(req.body);
    // we alwats need to respond with something
    res.json( { status: "ok" } );
})

app.get("/api", (req, res) => {
    res.json({message: "Hello World!"});
});

app.get("/api/users", (req, res) => {
    res.json(users)
});

const server = app.listen(port, () =>
    console.log(`Server is locked and loaded on port ${port}!`)
);
