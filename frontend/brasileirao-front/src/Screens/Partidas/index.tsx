
import { Input, Table } from "antd";
import { useEffect, useState } from "react";
import api from "../../services/api";
import { Partidas } from "./interfaces";

const Index: React.FC = () => {
    const [products, setProducts] = useState<Partidas[]>([] as Partidas[]);

    useEffect(() => {
        load();
    }, []);

    const load = async () => {
        const resp = await api.get<Partidas[]>("https://localhost:5001/api/Partidas/obter-por-rodada?rodada=6");

        const { data } = resp;
        setProducts(data);
    }

    const columns = [
        {
            title: 'Time Mandante',
            dataIndex: 'timeMandante'
        },
        {
            title: 'Time Visitante',
            dataIndex: 'timeVisitante'
        },
        {
            title: 'Localização',
            dataIndex: 'localizacao'
        },
        {
            title: 'Estádio',
            dataIndex: 'estadio'
        },
        {
            title: 'Data',
            dataIndex: 'dataJogo'
        }
    ];

    return (
        <Table
            columns={columns}
            dataSource={products}
            pagination={false}
            bordered

        />
    )
}

export default Index;
