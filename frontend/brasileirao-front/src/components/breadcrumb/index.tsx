import { Breadcrumb as BreadcrumbAntD } from 'antd';
import React from 'react';
import { useReducers } from 'react-resaga';
import { Link } from 'react-router-dom';

const Breadcrumb: React.FC = () => {

    const { breadcrumb = [] } = useReducers('breadcrumb');

    return (
        <BreadcrumbAntD style={{ fontSize: "large", padding: '12px' }}>
            {breadcrumb.map((item: any, key: number) => (
                <BreadcrumbAntD.Item key={key}>
                    {breadcrumb.length === key + 1 ? item.label : <Link to={item.route}>{item.label}</Link>}
                </BreadcrumbAntD.Item>
            ))}
        </BreadcrumbAntD>
    )
}

export default Breadcrumb;
