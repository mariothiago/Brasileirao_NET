import { Form, Popconfirm, Select, Table, Typography } from "antd";
import { useEffect, useState } from "react";
import api from "../../services/api";
import { Partidas } from './interfaces';

const Index: React.FC = () => {
    const [jogos, setJogos] = useState<Partidas[]>([] as Partidas[]);

    useEffect(() => {
        load();
    }, []);

    const load = async () => {
        const resp = await api.get<Partidas[]>("https://localhost:5001/api/Palpites/obter-palpites?rodada=7");

        const { data } = resp;
        setJogos(data);
    }

    const [form] = Form.useForm();
    const [data, setData] = useState(Array<Partidas>());
    const [editingKey, setEditingKey] = useState('');

    const isEditing = (record: Partidas) => record.id.toString() === editingKey;

    const edit = (record: Partidas) => {
        form.setFieldsValue({ name: '', age: '', address: '', ...record });
        setEditingKey(record.id.toString());
    };

    const cancel = () => {
        setEditingKey('');
    };

    const save = async (key: number) => {
        try {
            const row = (await form.validateFields()) as Partidas;

            const newData = [...jogos];
            const index = newData.findIndex(item => key === item.id);
            if (index > -1) {
                const item = newData[index];
                newData.splice(index, 1, {
                    ...item,
                    ...row,
                });
                setData(newData);
                setEditingKey('');
            } else {
                newData.push(row);
                setData(newData);
                setEditingKey('');
            }
        } catch (errInfo) {
            console.log('Validate Failed:', errInfo);
        }
    };

    const columns = [
        {
            title: 'Time Mandante',
            dataIndex: 'timeMandante'
        },
        {
            title: 'Placar',
            dataIndex: 'placarMandante',
            width: 10,
            editable: true
        },
        {
            title: 'Placar',
            dataIndex: 'placarVisitante',
            width: 10,
            editable: true
        },
        {
            title: 'Time Visitante',
            dataIndex: 'timeVisitante'
        },
        {
            title: 'Estádio',
            dataIndex: 'estadio'
        },
        {
            title: 'Local Partida',
            dataIndex: 'localizacao'
        },
        {
            title: 'Data',
            dataIndex: 'dataJogo'
        },
        {
            title: 'Ação',
            dataIndex: 'operation',
            render: (_: any, record: Partidas) => {
                const editable = isEditing(record);
                return editable ? (
                    <span>
                        <Typography.Link onClick={() => save(record.id)} style={{ marginRight: 8 }}>
                            Salvar
                        </Typography.Link>
                        <Popconfirm title="Tem certeza que deseja cancelar?" onConfirm={cancel} okText='Cancelar' cancelText='Não'>
                            <a>Cancelar</a>
                        </Popconfirm>
                    </span>
                ) : (
                    <Typography.Link disabled={editingKey !== ''} onClick={() => edit(record)}>
                        Editar
                    </Typography.Link>
                );
            },
        },

    ];

    return (
        <>
            <h1>Brasileirão 2022</h1>
            <h2>Seus palpites para a sétima rodada</h2>
            <Table
                columns={columns}
                dataSource={jogos}
                pagination={false}
                bordered
            />
        </>
    )
}

export default Index;
