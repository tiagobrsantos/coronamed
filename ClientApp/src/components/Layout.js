import React, { Component } from 'react';
import { Container, AppBar, Toolbar, IconButton, Typography, Button, Link, Menu, MenuItem } from '@material-ui/core';
import MenuIcon from '@material-ui/icons/Menu';
import FacebookIcon from '@material-ui/icons/Facebook';
import InstagramIcon from '@material-ui/icons/Instagram';
import YouTubeIcon from '@material-ui/icons/YouTube';
import LinkedInIcon from '@material-ui/icons/LinkedIn';
import TwitterIcon from '@material-ui/icons/Twitter';
import AccountCircle from '@material-ui/icons/AccountCircle';


export class Layout extends Component {
	static displayName = Layout.name;
	
	render() {



		return (
			<div className="body">
				<AppBar position="static" className="menu">
					<Toolbar>
						<IconButton edge="start" color="inherit" aria-label="menu">
							<MenuIcon />
						</IconButton>
						<Typography variant="h6" >
							CoronaMed
						</Typography>
						<Button color="inherit"></Button>

						<IconButton edge="end"
							aria-label="account of current user"
							aria-controls="menu-appbar"
							aria-haspopup="true"
							
							
						>
							<AccountCircle />
						</IconButton>

					</Toolbar>
				</AppBar>

				<Container>
					{this.props.children}
				</Container>

				<div className="footer">

					<IconButton href="#">
						<FacebookIcon />
					</IconButton>
					<IconButton href="#">
						<InstagramIcon />
					</IconButton>
					<IconButton href="#">
						<YouTubeIcon />
					</IconButton>
					<IconButton href="#">
						<LinkedInIcon />
					</IconButton>
					<IconButton href="#">
						<TwitterIcon />
					</IconButton>

				</div>

			</div>
		);
	}
}
