import React from "react";
import { Typography, Toolbar, AppBar } from "@mui/material";
import WorkHistoryIcon from '@mui/icons-material/WorkHistory';

export default function Header() {
	return (
		<AppBar position="relative">
			<Toolbar>
				<WorkHistoryIcon sx={{ mr: 2 }} />
				<Typography variant="h6" color="inherit" noWrap>
					Мониторинг зарплат
				</Typography>
			</Toolbar>
		</AppBar>)
}