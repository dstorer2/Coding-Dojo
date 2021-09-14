import React, { useState } from 'react'

const User = (props) => {
    const [firstName, setFirstName] = useState("");
    const [firstNameError, setFirstNameError] = useState("");

    const [lastName, setLastName] = useState("");
    const [lastNameError, setLastNameError] = useState("");

    const [email, setEmail] = useState("");
    const [emailError, setEmailError] = useState("");

    const [password, setPassword] = useState("");
    const [confirm, setConfirm] = useState("");
    const [confirmError, setConfirmError] = useState("");

    const createUser = (e) => {
        e.preventDefault();
        const newUser = { firstName, lastName, email, password, confirm };
        console.log("Welcome", newUser);
        setFirstName("");
        setLastName("");
        setEmail("");
        setPassword("");
        setConfirm("");
    };

    const handleFirstName = (event) => {
        setFirstName(event.target.value);
        if(event.target.value.length < 3){
            setFirstNameError("First Name must be at least 3 characters")
        }
    }

    const handleLastName = (event) => {
        setLastName(event.target.value);
        if(event.target.value.length < 3){
            setLastNameError("Last Name must be at least 3 characters")
        }
    }

    const handleEmail = (event) => {
        setEmail(event.target.value);
        if(event.target.value.length < 5){
            setEmailError("Email must be at least 5 characters long")
        }
    }
    const handlePassword = (event) => {
        setConfirm(event.target.value);
        if(event.target.value !== {password} ){
            setConfirmError("Password and confirmation must match")
        }
    }

    return(
        <div>
            <form onSubmit={ createUser }>
                <div>
                    <label>First Name:</label>
                    <input type="text" onChange={handleFirstName} value={ firstName }/>
                    {
                        firstNameError ? <p>{firstNameError}</p> : ''
                    }
                </div>
                <div>
                    <label>Last Name:</label>
                    <input type="text" onChange={handleLastName} value={ lastName }/>
                    {
                        lastNameError ? <p>{lastNameError}</p> : ''
                    }
                </div>
                <div>
                    <label>Email:</label>
                    <input type="text" onChange={ handleEmail } value={ email }/>
                    {
                        emailError ? <p>{emailError}</p> : ''
                    }
                </div>
                <div>
                    <label>Password:</label>
                    <input type="text" onChange={ (event) => setPassword(event.target.value) } value={ password }/>
                </div>
                <div>
                    <label>Confirm password:</label>
                    <input type="text" onChange={ handlePassword } value={ confirm }/>
                    {
                        confirmError ? <p>{confirmError}</p> : ''
                    }
                </div>
                <input type="submit" value=" Create User"/>
            </form>
            <p>First Name: { firstName }</p>
            <p>Last Name: { lastName }</p>
            <p>Email: { email }</p>
            <p>Password: { password }</p>
            <p>Confirm Password: { confirm }</p>
        </div>


    )
} 

export default User;