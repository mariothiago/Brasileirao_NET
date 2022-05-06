import React from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Table } from 'antd';
import { Partidas } from './Screens/Partidas/interfaces';

const dataSource = [
  {
    key: '1',
    name: 'Mike',
    age: 32,
    address: '10 Downing Street',
  },
  {
    key: '2',
    name: 'John',
    age: 42,
    address: '10 Downing Street',
  },
];

const columns = [
  {
    title: 'Name',
    dataIndex: 'name',
    key: 'name',
  },
  {
    title: 'Age',
    dataIndex: 'age',
    key: 'age',
  },
  {
    title: 'Address',
    dataIndex: 'address',
    key: 'address',
  },
];

function App() {
  return (
    <Table columns={columns} dataSource={dataSource} pagination={false} />
  );
}

export default App;
