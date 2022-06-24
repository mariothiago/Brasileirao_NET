import {
    HomeOutlined,
    MenuFoldOutlined,
    MenuUnfoldOutlined
} from '@ant-design/icons';
import { Layout, Menu, Tooltip } from 'antd';
import React, { useState } from 'react';
import * as reactRouterDom from 'react-router-dom';

const { Sider } = Layout;
const { SubMenu } = Menu;

const Index: React.FC = () => {
    const [collapsed, setCollapsed] = useState(false);

    const onCollapse = (collapse: boolean) => {
        setCollapsed(collapse);
    };

    return (
        <Sider
            trigger={null}
            reverseArrow={true}
            collapsible
            collapsed={collapsed}
            onCollapse={onCollapse}
        >
            <div
                style={{
                    padding: '17.5px',
                    color: '#fff',
                    cursor: 'pointer',
                    fontSize: '25px',
                    textAlign: 'right',
                    marginRight: '16px'
                }}
                onClick={() => onCollapse(!collapsed)}
            >
                {collapsed ? <MenuFoldOutlined /> : <MenuUnfoldOutlined />}
            </div>
            <Menu theme="light" defaultSelectedKeys={['1']} mode="vertical">
                <Menu.Item key="1" icon={<HomeOutlined />}>
                    <Tooltip title="Início">
                        <reactRouterDom.Link to={routeMainHome}>Início</reactRouterDom.Link>
                    </Tooltip>
                </Menu.Item>

                <Menu.Item key="2" icon={<HomeOutlined />}>
                    <Tooltip title="Início">
                        <reactRouterDom.Link to={routeMainPalpites}>Palpites</reactRouterDom.Link>
                    </Tooltip>
                </Menu.Item>
            </Menu>
        </Sider>
    );
};

export default Index;
