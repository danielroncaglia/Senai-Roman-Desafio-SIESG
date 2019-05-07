import React, { Component } from "react";

import api from "../services/api";

class Login extends Component {
    static navigationOptions ={
        header: null
    };

    constructor(props) {
        super(props);
        this.state = { email: "", senha: ""};
    }

    _realizarLogin = async () => {
        
    }
}