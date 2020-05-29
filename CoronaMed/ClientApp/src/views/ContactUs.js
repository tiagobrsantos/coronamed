import React from 'react';
import { makeStyles, useTheme } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import TextField from '@material-ui/core/TextField';
import TextAreaAutosize from '@material-ui/core/TextareaAutosize';
import IconButton from '@material-ui/core/IconButton';
import Typography from '@material-ui/core/Typography';
import { Container, CardActions, Button, TextareaAutosize } from '@material-ui/core';





export class ContactUs extends React.Component {

	constructor(props) {
		super(props);
		this.state = {};

	}

	render() {

		return (
			<Container fixed>
				<Card>
					<CardContent>
						<form>
							<div>
								<TextField required id="txtEmail" label="E-Mail" defaultValue="xx@xxx" />
							</div>
							<TextField required id="txtTelefone" label="Telefone" defaultValue="" />
							
						</form>
					</CardContent>
				</Card>
			</Container>
		)
	}
}