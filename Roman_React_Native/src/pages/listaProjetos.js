import React, { Component } from "react";

import {
    Text,
    View,
    FlatList,
    StyleSheet,
    Image,
    ImageBackground,
    TextInput,
    TouchableOpacity,
    AsyncStorage
} from "react-native";

import api from "../services/api";
import Cabecalho from "../assets/components/cabecalho/HeadListaProjeto";

export default class ListaProjetos extends Component{
    constructor(props){
        super(props);

        this.state = {
            lista: []
        }
    }

    componentDidMount(){
        this.carregarProjetos()
    }

    carregarProjetos = async () =>{
        const resposta = await api.get("/projetos");
        const dadosDaApi = resposta.data;
        this.setState({ lista : dadosDaApi });
    }

    render() {
        return(
            <View>
                <Text>Pagina de Lista de projetos</Text>
                <FlatList
                    data={this.state.lista}
                    keyExtractor={item => item.id}
                    renderItem={this.renderizaItem}
                />
            </View>
        )
    }

    renderizaItem = ({item}) => (
        <View>
            <Text>{item.nomeProjeto}</Text>
            <Text>{item.tema}</Text>
            <Text>{item.descricao}</Text>
            <Text>{item.idProfessor}</Text>
        </View>

// {
//     "id": 8,
//     "nomeProjeto": "Roman",
//     "descricao": "Compartilhamento de projetos",
//     "tema": "Projetos",
//     "idProfessor": 2,
//     "situacao": 1
// },
    )

}