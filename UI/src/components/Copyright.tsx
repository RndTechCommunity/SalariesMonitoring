import { Typography, Link } from "@mui/material";
import React from "react";

export default function Copyright() {
	return (
		<Typography variant="body2" color="text.secondary" align="center">
			{'Заботливо сделано '}
			<Link color="inherit" href="https://vk.com/rndtech">
				Ростовским ИТ-сообществом
			</Link>{' '}
			{new Date().getFullYear()}
			{'.'}
		</Typography>
		);
}