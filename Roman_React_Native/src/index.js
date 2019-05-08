import {
    createBottomTabNavigator,
    createAppContainer,
    createStackNavigator,
    createSwitchNavigator
} from "react-native";

import CadastroProfessor from "./pages/cadastroProfessor";
import CadastroProjetos from "./pages/cadastroProjetos";
import CadastroUsuario from "./pages/cadastroUsuario";
import ListaProjetos from "./pages/listaProjetos";
import Login from "./pages/login";

const AuthStack = createStackNavigator ({ Login });

const ListaProjetosNavigator = createBottomTabNavigator(
    {
        ListaProjetos,
        CadastroProfessor,
        CadastroProjetos,
        CadastroUsuario
    },
    {
        initialRouteName: "ListaProjetos",
        swipeEnabled: true, 
        tabBarOptions: {
            showLabel: false,
            showIcon: true,
            inactiveBackgroundColor: "#dd99ff",
      activeBackgroundColor: "#B727FF",
      activeTintColor: "#FFFFFF",
      inactiveTintColor: "#FFFFFF",
      style: {
        height: 50
        }

    }
}
);


    export default createAppContainer(
        createSwitchNavigator(
            {
                ListaProjetosNavigator,
                AuthStack
            },
            {
                initialRouteName: "AuthStack"
            }
        )
    );