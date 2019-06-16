import React from 'react'
import { Card, CardImg, CardText, CardBody,
  CardTitle, CardSubtitle, Button } from 'reactstrap';


const SportItem = ({item, changeCoeff, logged}) => (
    <Card>
        <CardBody>
          <CardTitle>{item.eventName}</CardTitle>
          <CardSubtitle>Sport: {item.sport.name}</CardSubtitle>
          <CardSubtitle>League: {item.league.name}</CardSubtitle>
          <CardSubtitle>{item.eventName.split(/vs/g)[0]} odds: {item.homeTeamOdds.toLocaleString(navigator.language, { maximumFractionDigits: 2 })}</CardSubtitle>
          <CardSubtitle>{item.eventName.split(/vs/g)[1]} odds: {item.awayTeamOdds.toLocaleString(navigator.language, { maximumFractionDigits: 2 })}</CardSubtitle>
          <CardSubtitle>Draw odds: {item.drawOdds.toLocaleString(navigator.language, { maximumFractionDigits: 2 })}</CardSubtitle>
          {logged ? <Button onClick={() => {changeCoeff(item, 0)}}>Bet on {item.eventName.split(/vs/g)[0]}</Button>: ''}
          {logged ? <Button onClick={() => {changeCoeff(item, 1)}}>Bet on {item.eventName.split(/vs/g)[1]}</Button>: ''}
          {logged ? <Button onClick={() => {changeCoeff(item, 2)}}>Draw</Button>: ''}
        </CardBody>
      </Card>
);

export default SportItem;