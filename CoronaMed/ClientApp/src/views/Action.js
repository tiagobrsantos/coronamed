import React, { Component } from 'react';
import { Container, Grid, Card, CardMedia, CardContent, Typography, Paper, CardActions, Button, CardHeader } from '@material-ui/core';


export class Action extends Component {

	render() {
		return (
			<Container fixed>

				<Grid direction="row" justify="center" alignItems="center" spacing="3" >
					<Grid className="action-title" item xs={12}>

						<Typography variant="h3">
							MÁSCARAS DE TECIDO PARA POPULAÇÃO
						</Typography>

					</Grid>

				</Grid>

				<Grid direction="row" justify="center" alignItems="center" spacing="3" >
					<Grid item xs={12}>
						<Card spacing={3}>
							<Typography gutterBottom variant="h5" component="h2">
								Demanda
							</Typography>
							<Typography variant="body2" component="p">
								Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
								across all continents except Antarctica
							</Typography>
						</Card>
					</Grid>
				</Grid>

				<Grid direction="row" justify="center" alignItems="center" spacing="3" >
					<Grid item xs={6}>
						<Card >
							<Typography gutterBottom variant="h5" component="h2">
								Meta de Produção
							</Typography>
							<Typography variant="body2" component="p">
								10000
							</Typography>
						</Card>
					</Grid>
					<Grid item xs={6}>
						<Card s>
							<Typography gutterBottom variant="h5" component="h2">
								Capacidade Atual
							</Typography>
							<Typography variant="body2" component="p">
								2500
							</Typography>
						</Card>
					</Grid>
				</Grid>

			</Container>
		);
	}
}