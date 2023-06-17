import React from "react";
import { Typography, Box, Link } from "@mui/material";
import Copyright from "./Copyright";

export default function Footer() {
	return (
		<Box sx={{ bgcolor: 'background.paper', p: 6 }} component="footer">
			<Typography variant="h6" align="center" gutterBottom>
				Понравилось?
			</Typography>
			<Typography
				variant="subtitle1"
				align="center"
				color="text.secondary"
				component="p">
				А ещё у нас есть
				<Link color="inherit" href="https://vk.com/rndtech">
					исследование узнаваемости и привлекательности ИТ-компаний
				</Link>,{' '}
				<Link color="inherit" href="https://t.me/RndTechChat">
					телеграм-чат
				</Link>{' '}
				и много других интересных штук.
			</Typography>
			<Copyright />
		</Box>
		)
}