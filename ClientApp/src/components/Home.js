import React, { Component } from 'react';
import { Container, Card, CardActionArea, CardMedia, CardContent, CardActions, Button, Typography } from '@material-ui/core';
import foto from '../images/CoronaMed.png';
import { Products } from '../views/products';

export class Home extends Component {
	static displayName = Home.name;

	render() {
		return (
			<Container fixed>
				<Card >
					<CardMedia
						className="image"
						image={foto}
						title="Nurse"
					/>
					<CardContent>
						<Typography variant="h5" component="h2">
							Ajude a proteger os profissionais de Saúde
				            </Typography>
						<Typography variant="body2" color="textSecondary" component="p">
							Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
							across all continents except Antarctica
						</Typography>
						<Typography variant="body2" color="textSecondary" component="p">
							Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
							across all continents except Antarctica
							Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
							across all continents except Antarctica
							Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
							across all continents except Antarctica
						</Typography>
					</CardContent>
					<CardActions>
						<Button size="small" color="primary">
							Como Ajudar?
						</Button>
						<Button size="small" color="primary">
							Conheça as Açõoes
						</Button>
					</CardActions>
				</Card>

				<Products/>

			</Container>
		);
	}
}
