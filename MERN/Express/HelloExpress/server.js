const express = require("express");
const app = express();
const port = 8000;
const users = [
  {firstName: "Reimu", lastName: "Hakurei"},
  {firstName: "Marisa", lastName: "Kirisame"},
  {firstName: "Sanae", lastName: "Kochiya"},
  {firstName: "Sakuya", lastName: "Izayoi"},
  {firstName: "Momiji", lastName: "Inubashiri"}
]

app.use( express.json() );
app.use( express.urlencoded({ extended: true }) );

app.post("/api/users", (req, res) => {
  // req.body will contain the form data from Postman or from React
  console.log(req.body);
  // we can push it into the users array for now...
  // later on this will be inserted into a database
  users.push(req.body);
  // we alwats need to respond with something
  res.json( { status: "ok" } );
})

// GET A USER BY ID

// if we want to get a user with a specific id, we can made the id a part of the url
// be sure to preface the id variable with a ':' colon
app.get("/api/users/:id", (req, res) => {
  // we can get this 'id' variable from the req.params
  console.log(req.params.id);
  // assuming this id is the index of the users array we could return one user this way
  res.json( users[req.params.id] );
})

// UPDATE DATA
app.put("/api/users/:id", (req, res) => {
  // we can get this 'id' variable from req.params
  const id = req.params.id;
  // assuming this id is the index of the users array we can replace the user like so
  users[id] = req.body;
  // we always need to respond with something
  res.json( { status: "ok" } );
})

// DELETING DATA
app.delete("/api/users/:id", (req, res) => {
  // we can get this 'id' variable from req.params
  const id = req.params.id;
  // assuming this id is the index of the users array we can remove the user like so
  users.splice(id, 1);
  // we always need to respond with something
  res.json( { status: "ok" } );
})

// req is short for request
// res is short for response
app.get("/api", (req, res) => {
  res.json({message: "Hello World!"});
});

app.get("/api/users", (req, res) => {
  res.json(users)
});

const server = app.listen(port, () =>
  console.log(`Server is locked and loaded on port ${port}!`)
);
