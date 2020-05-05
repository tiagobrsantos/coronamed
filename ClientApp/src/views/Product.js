import React from 'react';
import { makeStyles, useTheme } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import CardMedia from '@material-ui/core/CardMedia';
import IconButton from '@material-ui/core/IconButton';
import Typography from '@material-ui/core/Typography';
import SkipPreviousIcon from '@material-ui/icons/SkipPrevious';
import PlayArrowIcon from '@material-ui/icons/PlayArrow';
import SkipNextIcon from '@material-ui/icons/SkipNext';
import { Container, CardActions, Button } from '@material-ui/core';





export class Product extends React.Component {

	constructor(props) {
		super(props);
		this.state = {};

	}


	render() {

		return (
			<Container fixed>

				<Card className={"product-page"}>
					<CardMedia
						className="product-image"
						image="https://picsum.photos/600/400"
						title="Live from space album cover"
					/>	
					<div className={"product-details"}>
						<CardContent className={"product-description"}>
							<Typography component="h5" variant="h5">
								Product XPTO
						    </Typography>
							<Typography variant="subtitle1" color="textSecondary">
								Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
							</Typography>
						</CardContent>
						<div className={"controls"}>
							<IconButton aria-label="previous">
								<SkipNextIcon />
							</IconButton>
							<IconButton aria-label="play/pause">
								<PlayArrowIcon  />
							</IconButton>
						
						</div>
					</div>
								
					
				</Card>
			</Container>
		);
	}
}