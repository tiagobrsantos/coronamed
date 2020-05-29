import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Products } from './views/Products';
import { Product } from './views/Product';
import { Action } from './views/Action';
import { ContactUs } from './views/ContactUs';
import './custom.css'

export default class App extends Component {
	static displayName = App.name;

	render() {
		return (
			<Layout>
				<Route exact path='/' component={Home} />
				<Route path='/counter' component={Counter} />
				<Route path='/fetch-data' component={FetchData} />
				<Route path='/products' component={Products} />
				<Route path='/product' component={Product} />
				<Route path='/action' component={Action} />
				<Route path='/contactus' component={ContactUs} />
			</Layout>
		);
	}
}
