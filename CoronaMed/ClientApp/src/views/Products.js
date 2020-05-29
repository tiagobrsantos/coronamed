import React, { Component } from 'react';
import { Container, Grid, Card, CardMedia, CardContent, Typography, Paper, CardActions, Button } from '@material-ui/core';


export class Products extends Component {

	render() {
		return (
			<Container fixed>

				<Grid container justify="center" >
					{[0, 1, 2].map((value) => (
						<Grid key={value} item>
							<Card className="productCard">
								<CardMedia
									className="image"
									image="https://picsum.photos/600/400"
									title="Contemplative Reptile"
								/>
								<CardContent>
									<Typography gutterBottom variant="h5" component="h2">
										Produto XPTO
										 </Typography>
									<Typography variant="body2" component="p">
										Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
										across all continents except Antarctica
										 </Typography>
									<Typography variant="h5" >
										R$ 22,99
										</Typography>
								</CardContent>
								<CardActions>
									<Button size="small">Comprar</Button>
								</CardActions>
							</Card>
						</Grid>
					))}
				</Grid>


			</Container>
		);
	}
}